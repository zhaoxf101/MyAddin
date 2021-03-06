using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_WFOfType))]
#if Dev
    [RunLocal]
#endif

	public class PM_WFOfType:ReadOnlyBase<PM_WFOfType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjTypeCode
        {
            get ;
            set ;
        }

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
        public string WorkflowGroup
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

		public static PM_WFOfType Create()
        {
            return EF.DataPortal.Create<PM_WFOfType>();
        }

		public static PM_WFOfType Fetch(System.Linq.Expressions.Expression<Func<PM_WFOfType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_WFOfType>(exp,values);
            return EF.DataPortal.Fetch<PM_WFOfType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_WFOfTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_WFOfTypes:ReadOnlyListBase<PM_WFOfTypes,PM_WFOfType>
    {
        #region Factory Methods

        public static PM_WFOfTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_WFOfTypes>();
        }

		public static PM_WFOfTypes Fetch(System.Linq.Expressions.Expression<Func<PM_WFOfType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_WFOfType>(exp,values);
            return EF.DataPortal.Fetch<PM_WFOfTypes>(lambda);
		}

		public static PM_WFOfTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_WFOfTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_WFOfTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_WFOfType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_WFOfTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_WFOfType>(exp,values)});
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
