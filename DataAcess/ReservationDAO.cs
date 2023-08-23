using BussinessObject2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class ReservationDAO
    {
        public static List<Reservation> GetReservations()
        {
            List<Reservation> listRes = new List<Reservation>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listRes = context.Reservations.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listRes;
        }

        public static void AddReservation(Reservation Reservation)
        {

            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Add(Reservation);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateReservation(Reservation reservation)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Entry<Reservation>(reservation).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
