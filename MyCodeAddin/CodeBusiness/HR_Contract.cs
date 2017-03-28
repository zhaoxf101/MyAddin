using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Contract))]
#if Dev
    [RunLocal]
#endif

	public class HR_Contract:ReadOnlyBase<HR_Contract>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ContractNo
        {
            get ;
            set ;
        }

		
        public string ContractType
        {
            get ;
            set ;
        }

		
        public string ContractText
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string EmpName
        {
            get ;
            set ;
        }

		
        public string IdType
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
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

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string PostTypeCode
        {
            get ;
            set ;
        }

		
        public string SalaryRangeCode
        {
            get ;
            set ;
        }

		
        public string PostCode
        {
            get ;
            set ;
        }

		
        public string TitleCode
        {
            get ;
            set ;
        }

		
        public string SalaryLevel
        {
            get ;
            set ;
        }

		
        public string FileNo
        {
            get ;
            set ;
        }

		
        public string ContractUrl
        {
            get ;
            set ;
        }

		
        public bool IsNewContract
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsEmp
        {
            get ;
            set ;
        }

		
        public bool IsAppovel
        {
            get ;
            set ;
        }

		
        public string RowStatus
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

		
		#endregion

		#region Factory Methods

		public static HR_Contract Create()
        {
            return EF.DataPortal.Create<HR_Contract>();
        }

		public static HR_Contract Fetch(System.Linq.Expressions.Expression<Func<HR_Contract, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Contract>(exp,values);
            return EF.DataPortal.Fetch<HR_Contract>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Contracts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Contracts:ReadOnlyListBase<HR_Contracts,HR_Contract>
    {
        #region Factory Methods

        public static HR_Contracts Fetch()
        {
            return EF.DataPortal.Fetch<HR_Contracts>();
        }

		public static HR_Contracts Fetch(System.Linq.Expressions.Expression<Func<HR_Contract, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Contract>(exp,values);
            return EF.DataPortal.Fetch<HR_Contracts>(lambda);
		}

		public static HR_Contracts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Contracts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Contracts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Contract, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Contracts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Contract>(exp,values)});
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
