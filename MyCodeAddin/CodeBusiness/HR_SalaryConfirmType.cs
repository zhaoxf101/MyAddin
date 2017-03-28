using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmType))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryConfirmType:ReadOnlyBase<HR_SalaryConfirmType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryConfirmType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string SalaryRanageCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryConfirmType Create()
        {
            return EF.DataPortal.Create<HR_SalaryConfirmType>();
        }

		public static HR_SalaryConfirmType Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmType>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryConfirmTypes:ReadOnlyListBase<HR_SalaryConfirmTypes,HR_SalaryConfirmType>
    {
        #region Factory Methods

        public static HR_SalaryConfirmTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypes>();
        }

		public static HR_SalaryConfirmTypes Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmType>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypes>(lambda);
		}

		public static HR_SalaryConfirmTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryConfirmTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryConfirmType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryConfirmType>(exp,values)});
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
