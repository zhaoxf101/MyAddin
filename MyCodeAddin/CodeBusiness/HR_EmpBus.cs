using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBus))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBus:ReadOnlyBase<HR_EmpBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpBusNo
        {
            get ;
            set ;
        }

		
        public string EmpBusText
        {
            get ;
            set ;
        }

		
        public string FileNo
        {
            get ;
            set ;
        }

		
        public string EmpEvent
        {
            get ;
            set ;
        }

		
        public string WorkFowId
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string ContractNo
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsBatch
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsAppoved
        {
            get ;
            set ;
        }

		
        public bool IsConfirmSalary
        {
            get ;
            set ;
        }

		
        public string SalaryAlterNo
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

		public static HR_EmpBus Create()
        {
            return EF.DataPortal.Create<HR_EmpBus>();
        }

		public static HR_EmpBus Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBuss:ReadOnlyListBase<HR_EmpBuss,HR_EmpBus>
    {
        #region Factory Methods

        public static HR_EmpBuss Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBuss>();
        }

		public static HR_EmpBuss Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBuss>(lambda);
		}

		public static HR_EmpBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBus>(exp,values)});
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
