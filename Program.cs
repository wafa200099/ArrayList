namespace ArrayList;

class Program
{
 public static void Main(string[] args)
 {
  // BusRoute B1 = new BusRoute(10,"new","york");
  // BusRoute B2 = new BusRoute(20,"new2","york2");
  //
  // BusRoute[] routes = [B1, B2];
  // foreach (BusRoute route in routes)
  // {
  //  Console.WriteLine(route);
  // }
  
  List<BusRoute> routes = new List<BusRoute>();
  
  routes.Add(new BusRoute(10,"new","yorkKKKK"));
  routes.Add(new BusRoute(20,"new","londonNNNNN"));
  Console.WriteLine($"The type of the routes list is: {routes.GetType()}");

  foreach (BusRoute route in routes )
  {
   Console.WriteLine(route);
   Console.WriteLine($"The type of route is: {route.GetType()}");

   
  }
  
  


  
 }

}