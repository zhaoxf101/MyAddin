using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AuthObjct))]
#if Dev
    [RunLocal]
#endif

	public class EF_AuthObjct:ReadOnlyBase<EF_AuthObjct>
    {
        #region Business Methods

		
        public string AObject
        {
            get ;
            set ;
        }

		
        public string AClass
        {
            get ;
            set ;
        }

		
        public string FBlock
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_AuthObjct Create()
        {
            return EF.DataPortal.Create<EF_AuthObjct>();
        }

		public static EF_AuthObjct Fetch(System.Linq.Expressions.Expression<Func<EF_AuthObjct, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthObjct>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthObjct>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AuthObjcts))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AuthObjcts:ReadOnlyListBase<EF_AuthObjcts,EF_AuthObjct>
    {
        #region Factory Methods

        public static EF_AuthObjcts Fetch()
        {
            return EF.DataPortal.Fetch<EF_AuthObjcts>();
        }

		public static EF_AuthObjcts Fetch(System.Linq.Expressions.Expression<Func<EF_AuthObjct, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthObjct>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthObjcts>(lambda);
		}

		public static EF_AuthObjcts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AuthObjcts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AuthObjcts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AuthObjct, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AuthObjcts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AuthObjct>(exp,values)});
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
