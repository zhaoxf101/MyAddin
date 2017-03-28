using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpContract))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpContract:ReadOnlyBase<HR_EmpContract>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string EmpCode
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

		
        public string ContractNo
        {
            get ;
            set ;
        }

		
        public string ContractText
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

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string ContractTypeCode
        {
            get ;
            set ;
        }

		
        public string EndReason
        {
            get ;
            set ;
        }

		
        public string EndText
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

		public static HR_EmpContract Create()
        {
            return EF.DataPortal.Create<HR_EmpContract>();
        }

		public static HR_EmpContract Fetch(System.Linq.Expressions.Expression<Func<HR_EmpContract, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpContract>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpContract>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpContracts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpContracts:ReadOnlyListBase<HR_EmpContracts,HR_EmpContract>
    {
        #region Factory Methods

        public static HR_EmpContracts Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpContracts>();
        }

		public static HR_EmpContracts Fetch(System.Linq.Expressions.Expression<Func<HR_EmpContract, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpContract>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpContracts>(lambda);
		}

		public static HR_EmpContracts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpContracts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpContracts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpContract, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpContracts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpContract>(exp,values)});
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
