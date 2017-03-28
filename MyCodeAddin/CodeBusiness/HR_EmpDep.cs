using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpDep))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpDep:ReadOnlyBase<HR_EmpDep>
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

		
        public string SDate
        {
            get ;
            set ;
        }

		
        public string EDate
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string RDDepCode
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

		public static HR_EmpDep Create()
        {
            return EF.DataPortal.Create<HR_EmpDep>();
        }

		public static HR_EmpDep Fetch(System.Linq.Expressions.Expression<Func<HR_EmpDep, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpDep>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpDep>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpDeps))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpDeps:ReadOnlyListBase<HR_EmpDeps,HR_EmpDep>
    {
        #region Factory Methods

        public static HR_EmpDeps Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpDeps>();
        }

		public static HR_EmpDeps Fetch(System.Linq.Expressions.Expression<Func<HR_EmpDep, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpDep>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpDeps>(lambda);
		}

		public static HR_EmpDeps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpDeps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpDeps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpDep, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpDeps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpDep>(exp,values)});
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
