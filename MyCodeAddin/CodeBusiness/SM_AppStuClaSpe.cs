using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppStuClaSpe))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppStuClaSpe:ReadOnlyBase<SM_AppStuClaSpe>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string StudentNo
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

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public bool IsN
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

		public static SM_AppStuClaSpe Create()
        {
            return EF.DataPortal.Create<SM_AppStuClaSpe>();
        }

		public static SM_AppStuClaSpe Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuClaSpe, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuClaSpe>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuClaSpe>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppStuClaSpes))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppStuClaSpes:ReadOnlyListBase<SM_AppStuClaSpes,SM_AppStuClaSpe>
    {
        #region Factory Methods

        public static SM_AppStuClaSpes Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppStuClaSpes>();
        }

		public static SM_AppStuClaSpes Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuClaSpe, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuClaSpe>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuClaSpes>(lambda);
		}

		public static SM_AppStuClaSpes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppStuClaSpes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppStuClaSpes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppStuClaSpe, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppStuClaSpes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppStuClaSpe>(exp,values)});
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
