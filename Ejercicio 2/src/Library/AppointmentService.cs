using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        //No se desarolla el programa con una orientacion a objetos. En su lugar se utiliza un String Builder.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name)) // Cada uno de estos debe de ser un set que verifique si el atributo del objeto esta vacio.
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false; //Deberia de retornar el valor false y detener la ejecucion del codigo para no consumir recursos.
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
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
                    return false;
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
                    return false;
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
                    return false;
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
                if (!String.IsNullOrEmpty(value)){
                    date = value;
                }else{
                    return false;
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
                    return false;
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
                    return false;
                }
            }
        }

    }
}
