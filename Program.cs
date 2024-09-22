namespace ArrayList;

class Program
{
 public static void Main(string[] args)
 {
  BusRoute B1 = new BusRoute(10,"new","york");
  BusRoute B2 = new BusRoute(20,"new2","york2");
  BusRoute B3 = new BusRoute(30,"new3","york3");
  
  BusRoute[] routesA = [B1, B2,B3];
  
  routesA[0] = new BusRoute(10,"new","york0");

  Array.Resize( ref routesA,1);
  
  foreach (BusRoute route in routesA)
  {
   Console.WriteLine(route);
  }
  
  List<BusRoute> routesL = new List<BusRoute>();
  
  routesL.Add(new BusRoute(10,"new","yorkKKKK"));
  routesL.Add(new BusRoute(20,"new","londonNNNNN"));
  routesL.Add(new BusRoute( 30,"new","canada"));
  routesL.Add(new BusRoute( 40,"new","new"));
  
  routesL.RemoveAll(r=> r.Destination == "new");
  routesL.RemoveAt(1);
  Console.WriteLine($"The type of the routes list is: {routesL.GetType()}");

  foreach (BusRoute route in routesL )
  {
   Console.WriteLine(route);
   // Console.WriteLine($"The type of route is: {route.GetType()}");

   
  }
  
  


  
 }

}