using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpOgn))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpOgn:ReadOnlyBase<HR_EmpOgn>
    {
        #region Business Methods

		
        public Guid ID
        {
            get ;
            set ;
        }

		
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

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpOgn Create()
        {
            return EF.DataPortal.Create<HR_EmpOgn>();
        }

		public static HR_EmpOgn Fetch(System.Linq.Expressions.Expression<Func<HR_EmpOgn, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpOgn>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpOgn>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpOgns))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpOgns:ReadOnlyListBase<HR_EmpOgns,HR_EmpOgn>
    {
        #region Factory Methods

        public static HR_EmpOgns Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpOgns>();
        }

		public static HR_EmpOgns Fetch(System.Linq.Expressions.Expression<Func<HR_EmpOgn, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpOgn>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpOgns>(lambda);
		}

		public static HR_EmpOgns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpOgns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpOgns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpOgn, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpOgns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpOgn>(exp,values)});
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
