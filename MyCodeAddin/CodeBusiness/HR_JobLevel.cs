using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_JobLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_JobLevel:ReadOnlyBase<HR_JobLevel>
    {
        #region Business Methods

		
        public string JobLevelCode
        {
            get ;
            set ;
        }

		
        public string JobLevelName
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

		public static HR_JobLevel Create()
        {
            return EF.DataPortal.Create<HR_JobLevel>();
        }

		public static HR_JobLevel Fetch(System.Linq.Expressions.Expression<Func<HR_JobLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_JobLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_JobLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_JobLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_JobLevels:ReadOnlyListBase<HR_JobLevels,HR_JobLevel>
    {
        #region Factory Methods

        public static HR_JobLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_JobLevels>();
        }

		public static HR_JobLevels Fetch(System.Linq.Expressions.Expression<Func<HR_JobLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_JobLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_JobLevels>(lambda);
		}

		public static HR_JobLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_JobLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_JobLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_JobLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_JobLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_JobLevel>(exp,values)});
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
