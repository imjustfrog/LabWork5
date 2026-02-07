using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ЛР_5___Вывод_данных_из_БД_через_UserControl.FolderforModel
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Table_Motorbike> Table_Motorbike { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
