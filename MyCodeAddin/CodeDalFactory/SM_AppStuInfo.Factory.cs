using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using EF.Data;
using EF.Linq;
using EF.Server;
using EFramework.DalLinq;

namespace Common.DalFactory
{
	public class SM_AppStuInfoFactory:Common.Business.SM_AppStuInfo
    {
        public static Common.Business.SM_AppStuInfo Fetch(SM_AppStuInfo data)
        {
            Common.Business.SM_AppStuInfo item = (Common.Business.SM_AppStuInfo)Activator.CreateInstance(typeof(Common.Business.SM_AppStuInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.StudentNo = data.StudentNo;
				                item.StudentName = data.StudentName;
				                item.SexCode = data.SexCode;
				                item.BirDate = data.BirDate;
				                item.IdNo = data.IdNo;
				                item.NationCode = data.NationCode;
				                item.Hometown = data.Hometown;
				                item.Origin = data.Origin;
				                item.PoliStatesCode = data.PoliStatesCode;
				                item.DepCode = data.DepCode;
				                item.ClassCode = data.ClassCode;
				                item.SpecialityCode = data.SpecialityCode;
				                item.DegreeCode = data.DegreeCode;
				                item.StudyPeriod = data.StudyPeriod;
				                item.LearnFormCode = data.LearnFormCode;
				                item.TrainDirection = data.TrainDirection;
				                item.EntDate = data.EntDate;
				                item.Tel = data.Tel;
				                item.MPhone = data.MPhone;
				                item.Email = data.Email;
				                item.HomeAddr = data.HomeAddr;
				                item.DormNo = data.DormNo;
				                item.RoomNo = data.RoomNo;
				                item.Memo = data.Memo;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_AppStuInfo>();
                var i = (from p in ctx.DataContext.SM_AppStuInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.StudentNo = i.StudentNo;
										this.StudentName = i.StudentName;
										this.SexCode = i.SexCode;
										this.BirDate = i.BirDate;
										this.IdNo = i.IdNo;
										this.NationCode = i.NationCode;
										this.Hometown = i.Hometown;
										this.Origin = i.Origin;
										this.PoliStatesCode = i.PoliStatesCode;
										this.DepCode = i.DepCode;
										this.ClassCode = i.ClassCode;
										this.SpecialityCode = i.SpecialityCode;
										this.DegreeCode = i.DegreeCode;
										this.StudyPeriod = i.StudyPeriod;
										this.LearnFormCode = i.LearnFormCode;
										this.TrainDirection = i.TrainDirection;
										this.EntDate = i.EntDate;
										this.Tel = i.Tel;
										this.MPhone = i.MPhone;
										this.Email = i.Email;
										this.HomeAddr = i.HomeAddr;
										this.DormNo = i.DormNo;
										this.RoomNo = i.RoomNo;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class SM_AppStuInfosFactory : Common.Business.SM_AppStuInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_AppStuInfo
                        select SM_AppStuInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Paging page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = (from p in ctx.DataContext.SM_AppStuInfo
                        select SM_AppStuInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

        private void DataPortal_Fetch(PagigExpress page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = page.Lambda.Resolve<SM_AppStuInfo>();
                var i = (from p in ctx.DataContext.SM_AppStuInfo.Where(exp)
                         select SM_AppStuInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = lambda.Resolve<SM_AppStuInfo>();
                var i = from p in ctx.DataContext.SM_AppStuInfo.Where(exp)
                         select SM_AppStuInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
