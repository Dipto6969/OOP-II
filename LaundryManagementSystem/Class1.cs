using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    internal class LMS
    {
        int ID;
        int shirt;
        int pants;
        int suits;
        int bedsheets;
        int orderid = 0;


        public LMS(int iD, int shirt, int pants, int suits, int bedsheets)
        {
            this.ID = iD;
            this.shirt = shirt;
            this.pants = pants;
            this.suits = suits;
            this.bedsheets = bedsheets;
        }

        public int getId() { return ID; }
        public int getShirt() { return shirt; }
        public int getPants() { return pants; }
        public int getSuits() { return suits; }
        public int getBedsheets() { return bedsheets; }
        public int getOrderid() { return orderid; }

    }

    class user : LMS
    {

      int id;
      string name;
      string address;
      int balance = 1000;

        List<user> users= new List<user>();


        public user(int iD, string name, string address)
        {
            this.id = iD;
            this.name = name;
            this.address = address;

        }

    }
}

