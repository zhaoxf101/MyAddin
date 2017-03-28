using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TCAuthDef))]
#if Dev
    [RunLocal]
#endif

	public class EF_TCAuthDef:ReadOnlyBase<EF_TCAuthDef>
    {
        #region Business Methods

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public int Counter
        {
            get ;
            set ;
        }

		
        public string AObject
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
        public string Low
        {
            get ;
            set ;
        }

		
        public string High
        {
            get ;
            set ;
        }

		
        public string LastUser
        {
            get ;
            set ;
        }

		
        public DateTime? LastDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_TCAuthDef Create()
        {
            return EF.DataPortal.Create<EF_TCAuthDef>();
        }

		public static EF_TCAuthDef Fetch(System.Linq.Expressions.Expression<Func<EF_TCAuthDef, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TCAuthDef>(exp,values);
            return EF.DataPortal.Fetch<EF_TCAuthDef>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TCAuthDefs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TCAuthDefs:ReadOnlyListBase<EF_TCAuthDefs,EF_TCAuthDef>
    {
        #region Factory Methods

        public static EF_TCAuthDefs Fetch()
        {
            return EF.DataPortal.Fetch<EF_TCAuthDefs>();
        }

		public static EF_TCAuthDefs Fetch(System.Linq.Expressions.Expression<Func<EF_TCAuthDef, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TCAuthDef>(exp,values);
            return EF.DataPortal.Fetch<EF_TCAuthDefs>(lambda);
		}

		public static EF_TCAuthDefs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TCAuthDefs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TCAuthDefs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TCAuthDef, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TCAuthDefs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TCAuthDef>(exp,values)});
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
