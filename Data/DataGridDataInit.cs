using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.Data
{
    public class DataGridDataInit
    {
        private static DataGridDataInit dataInit;

        public static DataGridDataInit Instance
        {
            get
            {
                if (dataInit==null)
                {
                    dataInit = new DataGridDataInit();
                }
                return dataInit;
            }
        }

        private DataGridDataInit()
        {
            CompanyClass = new List<CompanyClassModel>()
            {
                new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七asdsadasd",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七sddddddddddddddadssssssssssssssss",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七asdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七asdasdasdas",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七dsadasdasdsadasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七sdsadasdasdasdasd",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
                ,new CompanyClassModel(){
                    CompanyName="嘻嘻科技",
                    StaffName="小七asdasdasdasd",
                    Job="猫仔",
                    Age=17,
                    CreateTime=DateTime.Now,
                    Id=Guid.NewGuid()
                }
            };
        }

        public List<CompanyClassModel> CompanyClass { get; set; }
    }
}
