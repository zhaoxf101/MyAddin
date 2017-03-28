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
	public class SM_StudentInfoFactory:Common.Business.SM_StudentInfo
    {
        public static Common.Business.SM_StudentInfo Fetch(SM_StudentInfo data)
        {
            Common.Business.SM_StudentInfo item = (Common.Business.SM_StudentInfo)Activator.CreateInstance(typeof(Common.Business.SM_StudentInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.StudentNo = data.StudentNo;
				                item.PersonId = data.PersonId;
				                item.StudentName = data.StudentName;
				                item.Sex = data.Sex;
				                item.BirDate = data.BirDate;
				                item.Birth = data.Birth;
				                item.Nation = data.Nation;
				                item.Hometown = data.Hometown;
				                item.PoliStatesCode = data.PoliStatesCode;
				                item.Origin = data.Origin;
				                item.DepCode = data.DepCode;
				                item.ClassCode = data.ClassCode;
				                item.SpecialityCode = data.SpecialityCode;
				                item.DegreeCode = data.DegreeCode;
				                item.StudyPeriod = data.StudyPeriod;
				                item.LearnFormCode = data.LearnFormCode;
				                item.StudentStatusCode = data.StudentStatusCode;
				                item.CurrentGrade = data.CurrentGrade;
				                item.TrainDirection = data.TrainDirection;
				                item.IdNo = data.IdNo;
				                item.BankCardNo = data.BankCardNo;
				                item.CostCtr = data.CostCtr;
				                item.EntranceDate = data.EntranceDate;
				                item.EntDate = data.EntDate;
				                item.DormNo = data.DormNo;
				                item.RoomNo = data.RoomNo;
				                item.Tel = data.Tel;
				                item.MPhone = data.MPhone;
				                item.Email = data.Email;
				                item.HomeAddr = data.HomeAddr;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.IsInReg = data.IsInReg;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_StudentInfo>();
                var i = (from p in ctx.DataContext.SM_StudentInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.StudentNo = i.StudentNo;
										this.PersonId = i.PersonId;
										this.StudentName = i.StudentName;
										this.Sex = i.Sex;
										this.BirDate = i.BirDate;
										this.Birth = i.Birth;
										this.Nation = i.Nation;
										this.Hometown = i.Hometown;
										this.PoliStatesCode = i.PoliStatesCode;
										this.Origin = i.Origin;
										this.DepCode = i.DepCode;
										this.ClassCode = i.ClassCode;
										this.SpecialityCode = i.SpecialityCode;
										this.DegreeCode = i.DegreeCode;
										this.StudyPeriod = i.StudyPeriod;
										this.LearnFormCode = i.LearnFormCode;
										this.StudentStatusCode = i.StudentStatusCode;
										this.CurrentGrade = i.CurrentGrade;
										this.TrainDirection = i.TrainDirection;
										this.IdNo = i.IdNo;
										this.BankCardNo = i.BankCardNo;
										this.CostCtr = i.CostCtr;
										this.EntranceDate = i.EntranceDate;
										this.EntDate = i.EntDate;
										this.DormNo = i.DormNo;
										this.RoomNo = i.RoomNo;
										this.Tel = i.Tel;
										this.MPhone = i.MPhone;
										this.Email = i.Email;
										this.HomeAddr = i.HomeAddr;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.IsInReg = i.IsInReg;
					}
            }
        }
	}

	public class SM_StudentInfosFactory : Common.Business.SM_StudentInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_StudentInfo
                        select SM_StudentInfoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_StudentInfo
                        select SM_StudentInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_StudentInfo>();
                var i = (from p in ctx.DataContext.SM_StudentInfo.Where(exp)
                         select SM_StudentInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_StudentInfo>();
                var i = from p in ctx.DataContext.SM_StudentInfo.Where(exp)
                         select SM_StudentInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
