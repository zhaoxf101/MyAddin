using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusContract))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusContract:ReadOnlyBase<HR_EmpBusContract>
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

		
        public string EmpBusNo
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

		
        public string ActionType
        {
            get ;
            set ;
        }

		
        public Guid? OldId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpBusContract Create()
        {
            return EF.DataPortal.Create<HR_EmpBusContract>();
        }

		public static HR_EmpBusContract Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusContract, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusContract>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusContract>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusContracts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusContracts:ReadOnlyListBase<HR_EmpBusContracts,HR_EmpBusContract>
    {
        #region Factory Methods

        public static HR_EmpBusContracts Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusContracts>();
        }

		public static HR_EmpBusContracts Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusContract, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusContract>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusContracts>(lambda);
		}

		public static HR_EmpBusContracts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusContracts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusContracts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusContract, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusContracts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusContract>(exp,values)});
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
