﻿using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReservationRepository : IReservationRepository
    {
        public List<Reservation> GetReservations() => ReservationDAO.GetReservations();

        public void AddReservation(Reservation reservation) => ReservationDAO.AddReservation(reservation);

        public void UpdateReservation(Reservation reservation) => ReservationDAO.UpdateReservation(reservation);
    }
}
