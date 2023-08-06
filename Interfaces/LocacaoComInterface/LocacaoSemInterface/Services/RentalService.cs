using System;
using LocacaoComInterface.Entities;

namespace LocacaoComInterface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;
            if(duration.TotalHours <= 12)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerHour;
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
