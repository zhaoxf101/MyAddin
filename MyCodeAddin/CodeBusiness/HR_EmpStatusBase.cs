using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpStatusBase))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpStatusBase:ReadOnlyBase<HR_EmpStatusBase>
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

		
        public string StatusCode
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

		public static HR_EmpStatusBase Create()
        {
            return EF.DataPortal.Create<HR_EmpStatusBase>();
        }

		public static HR_EmpStatusBase Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatusBase, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatusBase>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatusBase>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpStatusBases))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpStatusBases:ReadOnlyListBase<HR_EmpStatusBases,HR_EmpStatusBase>
    {
        #region Factory Methods

        public static HR_EmpStatusBases Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBases>();
        }

		public static HR_EmpStatusBases Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatusBase, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatusBase>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatusBases>(lambda);
		}

		public static HR_EmpStatusBases Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBases>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpStatusBases Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpStatusBase, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBases>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpStatusBase>(exp,values)});
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
