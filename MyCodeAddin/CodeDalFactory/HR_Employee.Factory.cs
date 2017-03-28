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
	public class HR_EmployeeFactory:Common.Business.HR_Employee
    {
        public static Common.Business.HR_Employee Fetch(HR_Employee data)
        {
            Common.Business.HR_Employee item = (Common.Business.HR_Employee)Activator.CreateInstance(typeof(Common.Business.HR_Employee));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.PersonId = data.PersonId;
				                item.EmpTypeCode = data.EmpTypeCode;
				                item.StaffTypeCode = data.StaffTypeCode;
				                item.EmpName = data.EmpName;
				                item.Sex = data.Sex;
				                item.Country = data.Country;
				                item.Nation = data.Nation;
				                item.Hometown = data.Hometown;
				                item.Addr = data.Addr;
				                item.Birth = data.Birth;
				                item.Photo = data.Photo;
				                item.DepCode = data.DepCode;
				                item.CostCtr = data.CostCtr;
				                item.PositionCode = data.PositionCode;
				                item.PoliStatesCode = data.PoliStatesCode;
				                item.BankCardNo = data.BankCardNo;
				                item.PrimDepCode = data.PrimDepCode;
				                item.RDDepCode = data.RDDepCode;
				                item.Tel = data.Tel;
				                item.MobTel = data.MobTel;
				                item.Email = data.Email;
				                item.QQNo = data.QQNo;
				                item.WeiNo = data.WeiNo;
				                item.Graduated = data.Graduated;
				                item.GraduatedPro = data.GraduatedPro;
				                item.EduBackground = data.EduBackground;
				                item.Degree = data.Degree;
				                item.TitlesCode = data.TitlesCode;
				                item.PositionTypeCode = data.PositionTypeCode;
				                item.PostCode = data.PostCode;
				                item.SubDirection = data.SubDirection;
				                item.TeacherNo = data.TeacherNo;
				                item.IDCardTypeCode = data.IDCardTypeCode;
				                item.IdNo = data.IdNo;
				                item.PerStatus = data.PerStatus;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.RetireID = data.RetireID;
				                item.IsInReg = data.IsInReg;
				                item.IsSalary = data.IsSalary;
				                item.IsSalReturn = data.IsSalReturn;
				                item.IsInsReturn = data.IsInsReturn;
				                item.SocialSecurityNo = data.SocialSecurityNo;
				                item.OldSocialSecurityNo = data.OldSocialSecurityNo;
				                item.HousingFundNo = data.HousingFundNo;
				                item.memo = data.memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_Employee>();
                var i = (from p in ctx.DataContext.HR_Employee.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.PersonId = i.PersonId;
										this.EmpTypeCode = i.EmpTypeCode;
										this.StaffTypeCode = i.StaffTypeCode;
										this.EmpName = i.EmpName;
										this.Sex = i.Sex;
										this.Country = i.Country;
										this.Nation = i.Nation;
										this.Hometown = i.Hometown;
										this.Addr = i.Addr;
										this.Birth = i.Birth;
										this.Photo = i.Photo;
										this.DepCode = i.DepCode;
										this.CostCtr = i.CostCtr;
										this.PositionCode = i.PositionCode;
										this.PoliStatesCode = i.PoliStatesCode;
										this.BankCardNo = i.BankCardNo;
										this.PrimDepCode = i.PrimDepCode;
										this.RDDepCode = i.RDDepCode;
										this.Tel = i.Tel;
										this.MobTel = i.MobTel;
										this.Email = i.Email;
										this.QQNo = i.QQNo;
										this.WeiNo = i.WeiNo;
										this.Graduated = i.Graduated;
										this.GraduatedPro = i.GraduatedPro;
										this.EduBackground = i.EduBackground;
										this.Degree = i.Degree;
										this.TitlesCode = i.TitlesCode;
										this.PositionTypeCode = i.PositionTypeCode;
										this.PostCode = i.PostCode;
										this.SubDirection = i.SubDirection;
										this.TeacherNo = i.TeacherNo;
										this.IDCardTypeCode = i.IDCardTypeCode;
										this.IdNo = i.IdNo;
										this.PerStatus = i.PerStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.RetireID = i.RetireID;
										this.IsInReg = i.IsInReg;
										this.IsSalary = i.IsSalary;
										this.IsSalReturn = i.IsSalReturn;
										this.IsInsReturn = i.IsInsReturn;
										this.SocialSecurityNo = i.SocialSecurityNo;
										this.OldSocialSecurityNo = i.OldSocialSecurityNo;
										this.HousingFundNo = i.HousingFundNo;
										this.memo = i.memo;
					}
            }
        }
	}

	public class HR_EmployeesFactory : Common.Business.HR_Employees
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Employee
                        select HR_EmployeeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Employee
                        select HR_EmployeeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Employee>();
                var i = (from p in ctx.DataContext.HR_Employee.Where(exp)
                         select HR_EmployeeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Employee>();
                var i = from p in ctx.DataContext.HR_Employee.Where(exp)
                         select HR_EmployeeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
