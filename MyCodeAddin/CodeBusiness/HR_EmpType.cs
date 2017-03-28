using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpType))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpType:ReadOnlyBase<HR_EmpType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpTypeCode
        {
            get ;
            set ;
        }

		
        public string EmpTypeName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpType Create()
        {
            return EF.DataPortal.Create<HR_EmpType>();
        }

		public static HR_EmpType Fetch(System.Linq.Expressions.Expression<Func<HR_EmpType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpType>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpTypes:ReadOnlyListBase<HR_EmpTypes,HR_EmpType>
    {
        #region Factory Methods

        public static HR_EmpTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpTypes>();
        }

		public static HR_EmpTypes Fetch(System.Linq.Expressions.Expression<Func<HR_EmpType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpType>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpTypes>(lambda);
		}

		public static HR_EmpTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpType>(exp,values)});
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
