using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StuClaSpe))]
#if Dev
    [RunLocal]
#endif

	public class SM_StuClaSpe:ReadOnlyBase<SM_StuClaSpe>
    {
        #region Business Methods

		
        public string Client
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

		public static SM_StuClaSpe Create()
        {
            return EF.DataPortal.Create<SM_StuClaSpe>();
        }

		public static SM_StuClaSpe Fetch(System.Linq.Expressions.Expression<Func<SM_StuClaSpe, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StuClaSpe>(exp,values);
            return EF.DataPortal.Fetch<SM_StuClaSpe>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StuClaSpes))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StuClaSpes:ReadOnlyListBase<SM_StuClaSpes,SM_StuClaSpe>
    {
        #region Factory Methods

        public static SM_StuClaSpes Fetch()
        {
            return EF.DataPortal.Fetch<SM_StuClaSpes>();
        }

		public static SM_StuClaSpes Fetch(System.Linq.Expressions.Expression<Func<SM_StuClaSpe, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StuClaSpe>(exp,values);
            return EF.DataPortal.Fetch<SM_StuClaSpes>(lambda);
		}

		public static SM_StuClaSpes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StuClaSpes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StuClaSpes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StuClaSpe, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StuClaSpes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StuClaSpe>(exp,values)});
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
