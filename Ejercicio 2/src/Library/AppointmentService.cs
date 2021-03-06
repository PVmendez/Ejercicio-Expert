using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        string name;
        string id;
        string phoneNumber;
        DateTime date;
        string appointmentPlace;
        string doctorName;
        
        //No se desarolla el programa con una orientacion a objetos. En su lugar se utiliza un String Builder.
        //public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        public AppointmentService(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)

        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
            this.DoctorName = doctorName;
         
            //StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            //Boolean isValid = true; No es necesaria esta variable ya que se utiliza return
            /*
            if (string.IsNullOrEmpty(name)) // Cada uno de estos debe de ser un set que verifique si el atributo del objeto esta vacio.
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                //isValid = false; //Deberia de retornar el valor false y detener la ejecucion del codigo para no consumir recursos.
                return false
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                //isValid = false;
                return false
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                //isValid = false;
                return false
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appointment place is required\n");
                //isValid = false;
                return false
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                //isValid = false;
                return false
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
            }

            return stringBuilder.ToString();*/
        }

         public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)){
                    name = value;
                }else{
                     Console.WriteLine("Esta vacio");
                }
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)){
                    id = value;
                }else{
                    Console.WriteLine("Esta vacio");
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)){
                    PhoneNumber = value;
                }else{
                    Console.WriteLine("Esta vacio");
                }
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (!DateTime.IsNullOrEmpty(value)){
                    date = value;
                }else{
                    Console.WriteLine("Esta vacio");
                }
            }
        }
        public string AppointmentPlace
        {
            get
            {
                return appoinmentPlace;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)){
                    appoinmentPlace = value;
                }else{
                   Console.WriteLine("Esta vacio");
                }
            }
        }
        public string DoctorName
        {
            get
            {
                return doctorName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)){
                    doctorName = value;
                }else{
                    Console.WriteLine("Esta vacio");
                }
            }
        }

    }
}
