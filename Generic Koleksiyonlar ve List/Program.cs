using System;
using System.Collections.Generic
namespace generic_list
{
        List<int> numberList = new List<int> ();
numberList.Add(23);
numberList.Add(10);
numberList.Add(4);
numberList.Add(5);
numberList.Add(92);
numberList.Add(34);

List<string> colorList = new List<string> ();
colorList.Add("Kırmızı");
colorList.Add("Mavi");
colorList.Add("Turuncu");
colorList.Add("Sarı");
colorList.Add("Yeşil");

// Count 
Console.WriteLine(numberList.Count);
Console.WriteLine(colorList.Count);

// Foreach ve List.Foreach ile elemanlara erişmek
foreach (var number in numberList)
  Console.WriteLine(number);

foreach (var color in colorList)
  Console.WriteLine(color);

numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

// Listeden eleman çıkartmak
numberList.Remove(4);
colorList.Remove("Yeşil");
numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

numberList.RemoveAt(0);
colorList.RemoveAt(1);
numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

// Liste içerisinde arama yapmak
if(numberList.Contains(10))
  Console.WriteLine("10 liste içerisinde bulundu!");

// Eleman ile index'e erişme
Console.WriteLine(colorList.BinarySearch("Sarı"));


// Diziyi List'e çevirme
string[] animals = {"Kedi", "Köpek", "Kuş"};
List<string> animalList = new List<string> (animals);

// Listeyi temizlemek
animalList.Clear();

// List içrisinde nesne tutmak
List<Users> userList = new List<Users> ();
Users user1 = new Users();
user1.Name = "Ayşe";
user1.Surname = "Yılmaz";
user1.Age = 26;

Users user2 = new Users();
user2.Name = "Özcan";
user2.Surname = "Çalışkan";
user2.Age = 26;

userList.Add(user1);
userList.Add(user2);

List<Users> newList = new List<Users>();
newList.Add(new Users(){
  Name = "Deniz",
  Surname = "Arda",
  Age = 24
});

foreach (var user in userList)
{
  Console.WriteLine("Kullanıcı Adı:" + user.Name);
  Console.WriteLine("Kullanıcı Soyadı:" + user.Surname);
  Console.WriteLine("Kullanıcı Yaşı:" + user.Age);
}
public class Users{
  private string name;
  private string surname;
  private int age;

  public string Name {get => name; set => name = value;}
  public string Surname {get => surname; set => surname = value;}
  public int Age {get => age; set => age = value;}
}
}

