using System;
using AutoMapper;

namespace ConsoleApplication1
{
    public class FamilyModel
    {
        public int FamilyID { get; set; }
        public string FamilyName { get; set; }
    }

    public class SaveKitViewModel
    {
        public int FamilyID { get; set; }
        public string FamilyName { get; set; }
        public int UserId { get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FamilyModel, SaveKitViewModel>();
            }).CreateMapper();

            var existingSaveKitViewModel = new SaveKitViewModel
            {
                UserId = 1234
            };
            var familyModel = new FamilyModel
            {
                FamilyID = 9876,
                FamilyName = "Bloggs"
            };

            mapper.Map(familyModel, existingSaveKitViewModel);

            Console.WriteLine(existingSaveKitViewModel.FamilyID);
            Console.WriteLine(existingSaveKitViewModel.FamilyName);
            Console.WriteLine(existingSaveKitViewModel.UserId);

            // Obviously in a production system, you would bootstrap the Automapper MapperConfiguration just once, 
            // and then use the global Mapper.Map(familyModel, existingSaveKitViewModel); elsewhere when needed
        }
    }
}
