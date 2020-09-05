using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace GigmatesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    [ServiceContract]
    
    public interface IGigmatesService
    {

        [OperationContract]
        string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string greetings();


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        string derick();
        // TODO: Add your service operations here


        [OperationContract]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        string Login(LoginUser user);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        string RegisterUser(SignupUser user);
        
        //[OperationContract]
        //DataDB Login();
        /*
         CREATE FUNCTION FOR REGISTRATION
         LOGING IN - use an algorithm 
         */
    }

    [DataContract]
    public class SignupUser
    {
        string firstname, lastname, middlename, username, password, biography, location;
        float rate;
        int personType, age;

        [DataMember]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [DataMember]
        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        [DataMember]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string Biography
        {
            get { return biography; }
            set { biography = value; }
        }

        [DataMember]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        [DataMember]
        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        [DataMember]
        public int PersonType
        {
            get { return personType; }
            set { personType = value; }
        }

        [DataMember]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }

    [DataContract]
    public class LoginUser
    {
        string username, password;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        } 

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
