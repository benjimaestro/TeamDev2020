using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsLaptopUserCollection
    {
        //private data member for the allLaptopUsers list
        private List<clsLaptopUser> mAllLaptopUsers = new List<clsLaptopUser>();

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllLaptopUsers.Count;
            }
            set
            {
                //we will look at this later!
            }
        }
         
        //public property for allLaptopUsers
        public List<clsLaptopUser> AllLaptopUsers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllLaptopUsers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoing value to the private data member
                mAllLaptopUsers = value;
            }
        }
            //public constructor for the class
            public clsLaptopUserCollection()
            {
            //create an instance of the LaptopUser class to store a LaptopUser
            clsLaptopUser ALaptopUser = new clsLaptopUser();
            //set the LaptopUser to Eddie Rose
            ALaptopUser.LaptopUser = "Eddie Rose";
            //add the LaptopUse to the private list of LaptopUser
            mAllLaptopUsers.Add(ALaptopUser);
            //re initialise the aLaptopUser object to accept a new item
            ALaptopUser = new clsLaptopUser();
            //set the LaptopUser to Anna Kate
            ALaptopUser.LaptopUser = "Anna Kate";
            //add the second LaptopUser to the private list of Laptops
            mAllLaptopUsers.Add(ALaptopUser);
            //the private list now contains two LaptopUsers
            }
    }

}
