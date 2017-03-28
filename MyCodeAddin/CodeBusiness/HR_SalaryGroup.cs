using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryGroup))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryGroup:ReadOnlyBase<HR_SalaryGroup>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryGroupCode
        {
            get ;
            set ;
        }

		
        public string SalaryGroupName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryGroup Create()
        {
            return EF.DataPortal.Create<HR_SalaryGroup>();
        }

		public static HR_SalaryGroup Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryGroups:ReadOnlyListBase<HR_SalaryGroups,HR_SalaryGroup>
    {
        #region Factory Methods

        public static HR_SalaryGroups Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryGroups>();
        }

		public static HR_SalaryGroups Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryGroups>(lambda);
		}

		public static HR_SalaryGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryGroup>(exp,values)});
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
