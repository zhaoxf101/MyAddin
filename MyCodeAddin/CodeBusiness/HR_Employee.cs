using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Employee))]
#if Dev
    [RunLocal]
#endif

	public class HR_Employee:ReadOnlyBase<HR_Employee>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string EmpTypeCode
        {
            get ;
            set ;
        }

		
        public string StaffTypeCode
        {
            get ;
            set ;
        }

		
        public string EmpName
        {
            get ;
            set ;
        }

		
        public string Sex
        {
            get ;
            set ;
        }

		
        public string Country
        {
            get ;
            set ;
        }

		
        public string Nation
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public string Addr
        {
            get ;
            set ;
        }

		
        public DateTime? Birth
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary Photo
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string PoliStatesCode
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string PrimDepCode
        {
            get ;
            set ;
        }

		
        public string RDDepCode
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string MobTel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string QQNo
        {
            get ;
            set ;
        }

		
        public string WeiNo
        {
            get ;
            set ;
        }

		
        public string Graduated
        {
            get ;
            set ;
        }

		
        public string GraduatedPro
        {
            get ;
            set ;
        }

		
        public string EduBackground
        {
            get ;
            set ;
        }

		
        public string Degree
        {
            get ;
            set ;
        }

		
        public string TitlesCode
        {
            get ;
            set ;
        }

		
        public string PositionTypeCode
        {
            get ;
            set ;
        }

		
        public string PostCode
        {
            get ;
            set ;
        }

		
        public string SubDirection
        {
            get ;
            set ;
        }

		
        public string TeacherNo
        {
            get ;
            set ;
        }

		
        public string IDCardTypeCode
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public string PerStatus
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
        public string RetireID
        {
            get ;
            set ;
        }

		
        public bool IsInReg
        {
            get ;
            set ;
        }

		
        public bool IsSalary
        {
            get ;
            set ;
        }

		
        public bool IsSalReturn
        {
            get ;
            set ;
        }

		
        public bool IsInsReturn
        {
            get ;
            set ;
        }

		
        public string SocialSecurityNo
        {
            get ;
            set ;
        }

		
        public string OldSocialSecurityNo
        {
            get ;
            set ;
        }

		
        public string HousingFundNo
        {
            get ;
            set ;
        }

		
        public string memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Employee Create()
        {
            return EF.DataPortal.Create<HR_Employee>();
        }

		public static HR_Employee Fetch(System.Linq.Expressions.Expression<Func<HR_Employee, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Employee>(exp,values);
            return EF.DataPortal.Fetch<HR_Employee>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Employees))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Employees:ReadOnlyListBase<HR_Employees,HR_Employee>
    {
        #region Factory Methods

        public static HR_Employees Fetch()
        {
            return EF.DataPortal.Fetch<HR_Employees>();
        }

		public static HR_Employees Fetch(System.Linq.Expressions.Expression<Func<HR_Employee, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Employee>(exp,values);
            return EF.DataPortal.Fetch<HR_Employees>(lambda);
		}

		public static HR_Employees Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Employees>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Employees Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Employee, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Employees>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Employee>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
