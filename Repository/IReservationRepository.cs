using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReservationRepository
    {
        public List<Reservation> GetReservations();

        public void AddReservation(Reservation reservation);

        public void UpdateReservation(Reservation reservation);
    }
}
