using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class ReservationListForm : Form
    {
        LibraryManagementSystemEntities context;
        MainForm main;
        
        /// <summary>
        /// Initialization
        /// </summary>
        public ReservationListForm()
        {
            InitializeComponent();
        }

        //Close reservations that have already expired
        private void ReservationListForm_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
            CloseExpiredReservation();

            fieldcmb.SelectedIndex = 0;
            reservationListdgv.DataSource = context.Reservations.Where(x => x.ReservationStatus != "Close").Select(x => new
            {
                x.MemberID,
                Name = x.Member.FirstName + " " + x.Member.LastName,
                BookTitle = x.Book.Title,
                x.Member.PhoneNumber,
                x.ReservedOn
            }).OrderBy(x => x.ReservedOn).ToList();
            main = (MainForm)MdiParent;
        }

        //Search feature
        private void searchbtn_Click(object sender, EventArgs e)
        {
            List<Reservation> listReserve = new List<Reservation>();
            if (fieldcmb.Text == "Books")
            {
                foreach (Reservation reservation in context.Reservations.Where(x => x.ReservationStatus != "Close"))
                {
                    if (vagueSearch(searchtxt.Text, reservation.Book.Title))
                    {
                        listReserve.Add(reservation);
                    }
                }
            }
            else
            {
                foreach (Reservation reservation in context.Reservations.Where(x => x.ReservationStatus != "Close"))
                {
                    if (vagueSearch(searchtxt.Text, reservation.Member.FirstName) || vagueSearch(searchtxt.Text, reservation.Member.LastName))
                    {
                        listReserve.Add(reservation);
                    }
                }
            }

            if (listReserve.Count > 0)
            {
                main.StatusValue = "Search Complete!";
            }

            else
            {
                main.StatusValue = "No Data Found!";
            }

            reservationListdgv.DataSource = listReserve.Select(x => new
            {
                x.MemberID,
                Name = x.Member.FirstName + " " + x.Member.LastName,
                BookTitle = x.Book.Title,
                x.Member.PhoneNumber,
                x.ReservedOn
            }).OrderBy(x => x.ReservedOn).ToList();
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            searchbtn.PerformClick();
        }
        /// <summary>
        /// Methods
        /// </summary>

        //Close expired reservation
        private void CloseExpiredReservation()
        {
            DateTime today = DateTime.Now.Date;
            List<Reservation> reservations = context.Reservations.Where(x => x.ReservedUntil <= today).ToList();
            foreach (Reservation reservation in reservations)
            {
                reservation.ReservationStatus = "Close";
            }
            context.SaveChanges();
        }

        //Search any string in the word
        private bool vagueSearch(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i <= (s2.Length - s1.Length); i++)
                {
                    if (s2.Substring(i, s1.Length).ToLower() == s1.ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
