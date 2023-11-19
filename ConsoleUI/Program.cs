
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

CourseManager courseManager = new CourseManager(new EfCourseDal());
CourseEducatorManager courseEducatorMenager = new CourseEducatorManager(new EfCourseEducatorDal());

EducatorManager educatorManager = new EducatorManager(new EfEducatorDal());



//foreach (var course in courseManager.GetAll())
//{
//    Console.WriteLine(course.Name);
//}

//foreach (var course in courseManager.GetAllByCategoryId(2))
//{
//    Console.WriteLine(course.Name);
//}

//foreach (var course in courseManager.GetAllByUnitPrice(1000, 2000))
//{
//    Console.WriteLine(course.Name);
//}



//foreach (var courseEducator in courseEducatorMenager.GetAllByCourseId("Programlamaya Giriş"))
//{
//    foreach (var item in educatorManager.GetAllByEducatorId(courseEducator.EducatorId))
//    {
//        Console.WriteLine(item.EducatorName);
//    }

//}

