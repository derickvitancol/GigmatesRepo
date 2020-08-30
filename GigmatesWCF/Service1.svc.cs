using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GigmatesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class Service1 : IGigmatesService
    {
        private SqlConnection conn;

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public string greetings()
        {
            return "Hello werld";
        }

        //[WebInvoke(Method="GET",BodyStyle =WebMessageBodyStyle.Wrapped,ResponseFormat = WebMessageFormat.Json)]
        public string derick()
        {
            return "yow derick";
        }

        public string Login()
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(SignupUser user)
        {
            string message;
            int ret;

            //Replace data source, initial catalog, password, etc. in App config and in the code bellow
            string connectionString = ConfigurationManager.ConnectionStrings["SuccinctlyDB"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand("RegisterPerson", connection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@rate", user.Rate);
                sqlCommand.Parameters.AddWithValue("@location", user.Location);
                sqlCommand.Parameters.AddWithValue("@username", user.Username);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                sqlCommand.Parameters.AddWithValue("@bio", user.Biography);
                sqlCommand.Parameters.AddWithValue("@personType", user.PersonType);
                sqlCommand.Parameters.AddWithValue("@age", user.Age);

                conn.Open();

                ret = sqlCommand.ExecuteNonQuery();
                if (ret == 1)
                {
                    message = "Sign up successful";
                }
                else
                {
                    message = "Sign up failed";
                }

                return message;
            }
        }
    }

}
