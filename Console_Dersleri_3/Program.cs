using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LocationManager locationManager = new LocationManager(new EfLocationDal());
            //var values = locationManager.TGetList();


            //Lokasyon Listeleme
            //void Location_List() 
            //{
            //    foreach (var value in values)
            //    {
            //        Console.WriteLine(value.LocationName);
            //        Console.WriteLine("----------------");
            //    }
            //}

            //Location location = new Location();
            //location.LocationName = "Rotterdam";   //Değer Ekleme işlemi
            //locationManager.TInsert(location);
            //Location_List();

            //var locationValue = locationManager.TGetById(4);  //ID numarasına göre silme
            //locationManager.TDelete(locationValue);
            //Location_List();

            //var locationValue = locationManager.TGetById(2);  //Id numarasına göre değeri
            //locationValue.LocationName = "Çanakkale";          //değiştirme
            //locationManager.TUpdate(locationValue);
            //Console.WriteLine("Güncelleme yapıldı");


            //MEMBER İÇİN İŞLEMLER

            MemberManager memberManager = new MemberManager(new EfMemberDal());

            //Member verilerini listeleme

            //var values2 = memberManager.TGetList();
            //foreach (var value in values2)
            //{
            //    Console.WriteLine(value.MemberName + " " + value.MemberSurname);
            //    Console.WriteLine("--------------------------");
            //}

            //Member verilerine değer atama

            //Member member = new Member();
            //member.MemberName = "a";
            //member.MemberSurname = "b";
            //memberManager.TInsert(member);
            //Console.WriteLine("Ekleme yapıldı");

            //ID ye göre member verisi SİLME 

            //Member member1 = new Member();
            //var valueMember = memberManager.TGetById(4);
            //memberManager.TDelete(valueMember);
            //Console.WriteLine("Silme işlemi yapıldı");




            Console.ReadLine();
            
        }
    }

}
