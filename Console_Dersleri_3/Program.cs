using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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

            //MemberManager memberManager = new MemberManager(new EfMemberDal());

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

            //Id ye göre veri güncelleme
            //var valueMember2 = memberManager.TGetById(9);
            //valueMember2.MemberName = "Aslı";
            //valueMember2.MemberSurname = "Meşe";
            //memberManager.TUpdate(valueMember2);
            //Console.WriteLine("Güncelleme yapıldı");

            //COMMENT İLE İLGİLİ KOMUTLAR

            //CommentManager commentManager = new CommentManager(new EfCommentDal());

            //var values = commentManager.TGetList();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.CommentID + "-" + value.LocationID);
            //    Console.WriteLine("--------------------");
            //}

            //Entity Framework şeklinde join olarak yazdığımız metodu çağırdık.

            //CommentManager commentManager = new CommentManager(new EfCommentDal());
            //commentManager.TCommentListWithLocationAndMember();


            //FLUENT VALIDATION A UYGUN OLARAK ÜYE INSERT ETME
            MemberManager memberManager = new MemberManager(new EfMemberDal());

            Member member = new Member();
            member.MemberName = "a";  //1. örnek "Cemil"
            member.MemberSurname = "b";  //1.örnek "Kaya"
            MemberValidator validationRules = new MemberValidator();
            ValidationResult results = validationRules.Validate(member);

            if (results.IsValid)
            {
                memberManager.TInsert(member);
                Console.WriteLine(member.MemberName + " " + member.MemberSurname + " " + "başarılı bir şekilde eklendi ");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
         
            Console.ReadLine();
            
        }
    }
}
