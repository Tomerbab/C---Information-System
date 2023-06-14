using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Net.Mail;
using System.Net;


namespace Group11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<Shift> Shifts;
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Payment> Payments;
        public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<Purchase> Purchases;
        public static System.Collections.Generic.List<Meeting> Meetings;
        [STAThread]

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_customers();//אתחול הרשימה של הלקוחות
            init_employees();//אתחול הרשימה של העובדים
            init_suppliers();//אתחול הרשימה של הספקים
            init_payments();//אתחול הרשימה של התשלומים
            init_orders();//אתחול הרשימה של ההזמנות
            init_products();//אתחול הרשימה של המוצרין
            init_purchases();//אתחול הרשימה של הרכישות
            init_meetings();//אתחול רשימה של הפגישות
            init_shifts();//אתחול רשימה של המשמרות 
            init_productsInPurchase();//אתחול הרשימה של מוצרים ברכישה עבור כל מוצר וכל רכישה
            init_ProductsInOrders();//אתחול רשימה של מוצרים בהזמנה עבור כל מוצר וכל הזמנה
            init_ShiftConstraints();//אתחול רשימה של אילוצים למשמרות לכל משמרת ועובד
            init_WorkersInShift();// אתחול רשימה של עובדים במשמרת לכל עובד ומשמרת
            init_meetingForOrders();//אתחול רשימה של פגישות והזמנות לכל הזמנה ולכל פגישה

        }

        public static void init_customers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Customers = new List<Customer>();

            while (rdr.Read())
            {
                Customer cr = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), false);
                Customers.Add(cr);
            }
        }

        public static void init_employees()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Employees = new List<Employee>();

            while (rdr.Read())
            {
                Type T = (Type)Enum.Parse(typeof(Type), rdr.GetValue(10).ToString());
                Employee E = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse((rdr.GetValue(2).ToString())), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), DateTime.Parse((rdr.GetValue(6).ToString())), double.Parse((rdr.GetValue(7).ToString())), Boolean.Parse((rdr.GetValue(8).ToString())), rdr.GetValue(9).ToString(), T, false);
                Employees.Add(E);
            }
        }

        public static void init_meetings()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Meetings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Meetings = new List<Meeting>();

            while (rdr.Read())
            {
                Employee E = seekEmployee(rdr.GetValue(1).ToString());
                Customer C = seekCustomer(rdr.GetValue(2).ToString());
                Meeting M = new Meeting(DateTime.Parse(rdr.GetValue(0).ToString()), E, C, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), false);
                Meetings.Add(M);
            }
        }

        public static void init_suppliers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier S = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), false);
                Suppliers.Add(S);
            }
        }

        public static void init_orders()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Orders = new List<Order>();

            while (rdr.Read())
            {
                Customer C = seekCustomer(rdr.GetValue(4).ToString());
                Payment P = seekPayment(rdr.GetValue(5).ToString());
                OrderStatus S = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(3).ToString());
                if (P == null)
                {
                    Order O = new Order(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), S, C, null, false);
                    Orders.Add(O);
                }
                else
                {
                    Order O = new Order(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), S, C, P.getPaymentID(), false);
                    Orders.Add(O);
                }
            }
        }

        public static void init_ProductsInOrders()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ProductsInOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);


            while (rdr.Read())
            {
                Order O = Program.seekOrder(rdr.GetValue(0).ToString());
                Product P = Program.seekProduct(rdr.GetValue(1).ToString());
                ProductsInOrders PO = new ProductsInOrders(O, P, int.Parse(rdr.GetValue(2).ToString()), false);
                O.addProductsInOrders(PO);
                P.addProductsInOrders(PO);
            }
        }
        public static void init_payments()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Payments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Payments = new List<Payment>();

            while (rdr.Read())
            {
                Payment p = new Payment(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), DateTime.Parse((rdr.GetValue(3).ToString())), rdr.GetValue(4).ToString(), double.Parse(rdr.GetValue(5).ToString()), false);
                Payments.Add(p);

            }
        }
        public static void init_shifts()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Shifts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Shifts = new List<Shift>();

            while (rdr.Read())
            {
                ShiftType ST = (ShiftType)Enum.Parse(typeof(ShiftType), rdr.GetValue(1).ToString());
                Shift S = new Shift(DateTime.Parse(rdr.GetValue(0).ToString()), ST, int.Parse(rdr.GetValue(2).ToString()), false);
                Shifts.Add(S);
            }
        }
        public static void init_products()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Products = new List<Product>();

            while (rdr.Read())
            {
                Color C = (Color)Enum.Parse(typeof(Color), rdr.GetValue(5).ToString());
                ProductCategory PC = (ProductCategory)Enum.Parse(typeof(ProductCategory), rdr.GetValue(2).ToString());
                Supplier S = seekSupplier(rdr.GetValue(7).ToString());
                Product P = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), PC, rdr.GetValue(3).ToString(), double.Parse(rdr.GetValue(4).ToString()), C, int.Parse(rdr.GetValue(6).ToString()), S, false);
                Products.Add(P);
            }
        }

        public static void init_purchases()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Purchases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Purchases = new List<Purchase>();

            while (rdr.Read())
            {
                Employee E = seekEmployee(rdr.GetValue(3).ToString());
                Purchase P = new Purchase(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), E, false);
                Purchases.Add(P);
            }
        }
        public static void init_WorkersInShift() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ShiftWorkers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Employee E = Program.seekEmployee(rdr.GetValue(0).ToString());
                ShiftType ST = (ShiftType)Enum.Parse(typeof(ShiftType), rdr.GetValue(2).ToString());
                Shift s = Program.seekShift(DateTime.Parse(rdr.GetValue(1).ToString()), ST);
                E.addShiftToEmployee(s);
                s.addEmployeeToShift(E);
            }
        }
        public static void init_productsInPurchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ProductsInPurchase";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);


            while (rdr.Read())
            {
                Purchase purchase = Program.seekPurchase(rdr.GetValue(0).ToString());
                Product product = Program.seekProduct(rdr.GetValue(1).ToString());
                ProductsInPurchase P = new ProductsInPurchase(purchase, product, int.Parse(rdr.GetValue(2).ToString()), false);
                purchase.addProductsInPurchase(P);
                product.addProductsInPurchases(P);
            }
        }

        public static void init_ShiftConstraints()  
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ShiftConstraints";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                Employee E = Program.seekEmployee(rdr.GetValue(0).ToString());
                ShiftType ST = (ShiftType)Enum.Parse(typeof(ShiftType), rdr.GetValue(2).ToString());
                Shift S = Program.seekShift(DateTime.Parse(rdr.GetValue(1).ToString()), ST);
                ShiftConstraint sc = new ShiftConstraint(E, S, rdr.GetValue(3).ToString(), false);
                E.addShiftConstraints(sc);
                S.addShiftConstraints(sc);
            }
        }

        public static void init_meetingForOrders() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_MeetingsForOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Order O = Program.seekOrder(rdr.GetValue(1).ToString());
                Meeting M = Program.seekMeeting(DateTime.Parse(rdr.GetValue(0).ToString()));
                O.addMeeting(M);
                M.addOrder(O);
            }
        }


        public static Customer seekCustomer(string id)
        {
            foreach (Customer c in Customers)
            {
                if (c.get_customerID() == id)
                    return c;
            }
            return null;
        }
        public static Meeting seekMeeting(DateTime meetingDT)
        {
            foreach (Meeting M in Meetings)
            {
                if (M.getMeetingDT() == meetingDT)
                    return M;
            }
            return null;
        }


        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.getID() == id)
                    return e;
            }
            return null;
        }

        public static Supplier seekSupplier(string id)
        {
            foreach (Supplier c in Suppliers)
            {
                if (c.get_SupplierNumber() == id)
                    return c;
            }
            return null;
        }

        public static Product seekProduct(string serialNumber)
        {
            foreach (Product c in Products)
            {
                if (c.getSerialNumber() == serialNumber)
                    return c;
            }
            return null;
        }

        public static Payment seekPayment(string id)
        {
            foreach (Payment p in Payments)
            {
                if (p.getPaymentID() == id)
                    return p;
            }
            return null;
        }

        public static Purchase seekPurchase(string id)
        {
            foreach (Purchase p in Purchases)
            {
                if (p.getPurchaseNumber() == id)
                    return p;
            }
            return null;
        }

        public static Shift seekShift(DateTime shiftDate, ShiftType shiftType)
        {
            foreach (Shift s in Shifts)
            {
                if (s.getShiftDate().Equals(shiftDate) && s.getShiftType().ToString() == shiftType.ToString())
                {
                    return s;
                }
            }
            return null;
        }

        public static Order seekOrder(string id)
        {
            foreach (Order o in Orders)
            {
                if (o.getOrderNum() == id)
                    return o;
            }
            return null;
        }

        public static bool checkSupplier(string id)
        {
            if (seekSupplier(id) != null)
            {
                return true;
            }

            return false;
        }

        public static bool checkMeeting(DateTime meetingDT)
        {
            if (Program.seekMeeting(meetingDT) != null)
            {
                return true;
            }

            return false;
        }

        public static bool checkCustomer(String id)
        {
            if (Program.seekCustomer(id) != null)
            {
                return true;
            }

            return false;
        }
        public static bool checkPayment(String id)
        {
            if (Program.seekPayment(id) != null)
            {
                return true;
            }
            return false;
        }
        public static bool checkProduct(String id)
        {
            if (Program.seekProduct(id) != null)
            {
                return true;
            }
            return false;
        }
        public static bool checkPurchase(String id)
        {
            if (Program.seekPurchase(id) != null)
            {
                return true;
            }
            return false;
        }
        public static bool checkEmployee(String id)
        {
            if (Program.seekEmployee(id) != null)
            {
                return true;
            }

            return false;
        }

        public static bool checkOrder(string id)
        {
            if (Program.seekOrder(id) != null)
            {
                return true;
            }

            return false;
        }

        public static bool checkShift(DateTime shiftDate, ShiftType shiftType)
        {
            if (Program.seekShift(shiftDate, shiftType) != null)
            {
                return true;
            }

            return false;
        }


        public static bool hourAvailable(int year, int month, int day, int hour)
        {
            DateTime meetingDT = new DateTime(year, month, day, hour, 0, 0);
            if (Program.seekMeeting(meetingDT) != null)
            {
                return false;
            }
            return true;
        }

        public static Boolean fullyBooked(int year, int month, int day)
        {
            if (!Program.hourAvailable(year, month, day, 9) && !Program.hourAvailable(year, month, day, 12) && !Program.hourAvailable(year, month, day, 14) && !Program.hourAvailable(year, month, day, 17))
            {
                return true;
            }
            return false;
        }

             public static void sendEmail(string subject, string body, string Email)
        {
            string fromMail = "Group11AdiZak@gmail.com";
            string password = "ispmroqxyzdyzkve";
            string toAddress = Email;

            MailMessage message = new MailMessage(fromMail, toAddress, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential(fromMail, password);
            client.EnableSsl = true;
            client.Send(message);
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
             Application.Run(new Form_Main());

        }
    }
}
