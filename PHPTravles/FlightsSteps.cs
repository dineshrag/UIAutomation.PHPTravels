using PHPTravles.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PHPTravles
{
    [Binding]
    class FlightsSteps
    {
        Home home = new Home();
        AvailableFlights availableflights = new AvailableFlights();
        Booking booking = new Booking();
        Invoice invoice = new Invoice();

        [Given(@"I have opened PHPTravels website")]
        public void GivenIHaveOpenedPHPTravelsWebsite()
        {
            home.NavigatetoURL();
            home.Maximizewindow();
        }

        [Then(@"I can click on Flights options")]
        public void ThenICanClickOnFlightsOptions()
        {
            home.Clickonflights();
        }

        [Then(@"I choose trip as '(.*)'")]
        public void ThenIChooseTripAs(string TripType)
        {
            if (TripType.ToLower() == "roundtrip") home.Clickonroundtrip();
        }

        [Then(@"I enter cabin class as '(.*)'")]
        public void ThenIEnterCabinClassAs(string Cabinclass)
        {
            home.Selectcabinclass(Cabinclass);
        }

        [Then(@"I can enter From City or Airport as '(.*)'")]
        public void ThenICanEnterFromCityOrAirportAs(string fromcityrairport)
        {
            home.ClickFromcityairport();
            home.Fromcityairport(fromcityrairport);
            home.Selectcityairport();
        }

        [Then(@"I can enter To City or Airport as '(.*)'")]
        public void ThenICanEnterToCityOrAirportAs(string tocityorairport)
        {
            home.ClickTocityairport();
            home.Tocityairport(tocityorairport);
            home.Selectcityairport();
        }

        [Then(@"I ennter depature date as '(.*)'")]
        public void ThenIEnnterDepatureDateAs(string departuredate)
        {
            home.Departure(departuredate);
        }

        [Then(@"I ennter arrivale date as '(.*)'")]
        public void ThenIEnnterArrivaleDateAs(string arrivaldate)
        {
            home.Arrival(arrivaldate);
        }

        [Then(@"I click of number of passengers")]
        public void ThenIClickOfNumberOfPassengers()
        {
            home.Clickonpassengers();
        }

        [Then(@"I enter number of Adults as '(.*)'")]
        public void ThenIEnterNumberOfAdultsAs(string numberofadults)
        {
            home.VerifyPassengers();
            home.Enterpassengers(numberofadults);
        }

        [Then(@"I click on done")]
        public void ThenIClickOnDone()
        {
            home.Done();
        }

        [Then(@"I click on Search")]
        public void ThenIClickOnSearch()
        {
            home.Search();
        }

        [Then(@"I click on first available flight option")]
        public void ThenIClickOnFirstAvailableFlightOption()
        {
            availableflights.waituntilAvailableFlights();
            availableflights.Clickonavailableflight();
        }

        [Then(@"I click on signin")]
        public void ThenIClickOnSignin()
        {
            booking.waituntilSignIn();
            booking.ClickonSignIn();
        }

        [Then(@"I enter username and password details")]
        public void ThenIEnterUsernameAndPasswordDetails()
        {
            booking.EnterUsername(ConfigurationManager.AppSettings["username"].ToString());
            booking.EnterPassword(ConfigurationManager.AppSettings["password"].ToString());
        }

        [Then(@"I enter passenger Name '(.*)'")]
        public void ThenIEnterPassengerName(string passengername)
        {
            booking.EnterPassengerName(passengername);
        }

        [Then(@"I enter passenger age '(.*)'")]
        public void ThenIEnterPassengerAge(string passengerage)
        {
            booking.EnterPassengerAge(passengerage);
        }

        [Then(@"I enter passenger passport number '(.*)'")]
        public void ThenIEnterPassengerPassportNumber(string passportnumber)
        {
            booking.EnterPassportnumber(passportnumber);
        }

        [Then(@"I enter confirm booking")]
        public void ThenIEnterConfirmBooking()
        {
            booking.ClickConfirmBooking();
        }

        [Then(@"I verify the invoice")]
        public void ThenIVerifyTheInvoice()
        {
            invoice.waituntilInvoice();
        }


    }
}
