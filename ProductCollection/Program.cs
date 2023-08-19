using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductCRUD crud = new ProductCRUD();
            //int option = 0;
            //do 
            //{
            //    Console.WriteLine("1.Add Product");
            //    Console.WriteLine("2.Update Product");
            //    Console.WriteLine("3.Delete Product");
            //    Console.WriteLine("4.Display All Product");
            //    int op=Convert.ToInt32(Console.ReadLine());

            //    switch (op)
            //    {
            //        case 1:
            //            Product p1 = new Product();
            //            Console.WriteLine("Enter Product id");
            //            p1.Id = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter Product Name");
            //            p1.Name = Console.ReadLine();
            //            Console.WriteLine("Enter Product price");
            //            p1.Price= Convert.ToDouble(Console.ReadLine());

            //            crud.AddProduct(p1);
            //            break;
            //        case 2:
            //            Product p2 = new Product();
            //            Console.WriteLine("Enter id to modify");
            //            p2.Id = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter product name");
            //            p2.Name = Console.ReadLine();
            //    Console.WriteLine("Enter product price");
            //    p2.Price= Convert.ToDouble(Console.ReadLine());

            //    crud.UpdateProduct(p2);
            //    break;
            //case 3:
            //    Console.WriteLine("Enter id to delete");
            //    int id = Convert.ToInt32(Console.ReadLine());

            //    crud.DeleteProduct(id);
            //    break;
            //         case 4:
            //            List<Product> list = crud.GetProducts();
            //            foreach (Product p in list)
            //            {
            //                Console.WriteLine($"{p.Id}-->{p.Name}-->{p.Price}");
            //            }
            //            break;


            //    }
            //    Console.WriteLine("Press 1 for Continue");
            //    option=Convert.ToInt32(Console.ReadLine());


            //} while (option==1);



            //IEnumerable and Ienumerator

            //Team india = new Team();
            //foreach (Player p in india)
            //{
            //    Console.WriteLine(p);
            //}


            //Icomparable

            //ProductIcomparable Ac = new ProductIcomparable(40000, "Voltas");
            //ProductIcomparable Laptop = new ProductIcomparable(55000, "hp");
            //int result=Ac.CompareTo(Laptop);

            //if (result < 0)
            //{
            //    Console.WriteLine("Price of Voltass-AC is less than HP-Laptop");
            //}
            //else if(result > 0)
            //{
            //    Console.WriteLine("Price of Voltas-AC is higher than HP-Laptop ");
            //}
            //else
            //{
            //    Console.WriteLine("Price of Voltas-AC and HP-Laptop is equal");
            //}

            EmployeeIcomparer Gaurav = new EmployeeIcomparer { Name = "Gaurav", Salary = 40000 };
            EmployeeIcomparer Yash = new EmployeeIcomparer { Name = "Yash", Salary = 50000 };

            SalaryComparision obj = new SalaryComparision();
            int result=obj.Compare(Gaurav, Yash);

            if(result < 0 )
            {
                Console.WriteLine("Salary of gaurav is less than yash");
            }
            else if(result > 0 )
            {
                Console.WriteLine("Salary of gaurav is higher than yash");
            }
            else
            {
                Console.WriteLine("Salary of gaurav and yash are equal");
            }

        }

    }

         
            
            


        
           

        
    
            

                
                
}
                 



            
             
            
    


