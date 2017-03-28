using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_JobType))]
#if Dev
    [RunLocal]
#endif

	public class HR_JobType:ReadOnlyBase<HR_JobType>
    {
        #region Business Methods

		
        public string JobTypeCode
        {
            get ;
            set ;
        }

		
        public string JobTypeName
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

		public static HR_JobType Create()
        {
            return EF.DataPortal.Create<HR_JobType>();
        }

		public static HR_JobType Fetch(System.Linq.Expressions.Expression<Func<HR_JobType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_JobType>(exp,values);
            return EF.DataPortal.Fetch<HR_JobType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_JobTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_JobTypes:ReadOnlyListBase<HR_JobTypes,HR_JobType>
    {
        #region Factory Methods

        public static HR_JobTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_JobTypes>();
        }

		public static HR_JobTypes Fetch(System.Linq.Expressions.Expression<Func<HR_JobType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_JobType>(exp,values);
            return EF.DataPortal.Fetch<HR_JobTypes>(lambda);
		}

		public static HR_JobTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_JobTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_JobTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_JobType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_JobTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_JobType>(exp,values)});
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
