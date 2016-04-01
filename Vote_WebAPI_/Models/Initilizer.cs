using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vote_WebAPI_.Models
{
    public class Initilizer: DropCreateDatabaseAlways<ContexDB>
    {         
        protected override  void Seed(ContexDB context)
        {
            var user1 = new User{  IdUser=1,   NameUser="Admin"    };
            var user2 = new User { IdUser = 2, NameUser = "Admin2" };
             context.Users.Add(user1);
             context.Users.Add(user2);
             context.SaveChanges();                
        }

        //public override void InitializeDatabase(YourContext context)
        //{
        //    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
        //        , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

        //    base.InitializeDatabase(context);
        //}
        //protected override void Seed(SampleContext context)
        //{
        //    context.Database.ExecuteSqlCommand
        //         ("CREATE INDEX Index_Customer_Name ON Customers (CustomerId) INCLUDE (FirstName)");

        //    base.Seed(context);
        //}
    }
}