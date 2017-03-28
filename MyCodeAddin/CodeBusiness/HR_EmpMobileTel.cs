using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpMobileTel))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpMobileTel:ReadOnlyBase<HR_EmpMobileTel>
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

		
        public string MobileTel
        {
            get ;
            set ;
        }

		
        public bool Flag
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpMobileTel Create()
        {
            return EF.DataPortal.Create<HR_EmpMobileTel>();
        }

		public static HR_EmpMobileTel Fetch(System.Linq.Expressions.Expression<Func<HR_EmpMobileTel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpMobileTel>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpMobileTel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpMobileTels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpMobileTels:ReadOnlyListBase<HR_EmpMobileTels,HR_EmpMobileTel>
    {
        #region Factory Methods

        public static HR_EmpMobileTels Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpMobileTels>();
        }

		public static HR_EmpMobileTels Fetch(System.Linq.Expressions.Expression<Func<HR_EmpMobileTel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpMobileTel>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpMobileTels>(lambda);
		}

		public static HR_EmpMobileTels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpMobileTels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpMobileTels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpMobileTel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpMobileTels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpMobileTel>(exp,values)});
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
