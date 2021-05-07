using System;

namespace NOXHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularUser request = new RegularUser();

            SubProgram subprogram = new SubProgram();

            request.name = subprogram.setName();

            request.age = subprogram.setAge();

            request.gender = subprogram.setGender();

            request.height = subprogram.setHeight();

            request.weight = subprogram.setWeight();

            int isActive = subprogram.setProfession();
            request.setisActive(isActive);

            Diet result = new Diet();
            result.showRecommendation();
        }
    }
}
