using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_DomVals))]
#if Dev
    [RunLocal]
#endif

	public class EF_DomVals:ReadOnlyBase<EF_DomVals>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string Domain
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public int ValPos
        {
            get ;
            set ;
        }

		
        public string Val_L
        {
            get ;
            set ;
        }

		
        public string Val_H
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

		public static EF_DomVals Create()
        {
            return EF.DataPortal.Create<EF_DomVals>();
        }

		public static EF_DomVals Fetch(System.Linq.Expressions.Expression<Func<EF_DomVals, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_DomVals>(exp,values);
            return EF.DataPortal.Fetch<EF_DomVals>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_DomValss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_DomValss:ReadOnlyListBase<EF_DomValss,EF_DomVals>
    {
        #region Factory Methods

        public static EF_DomValss Fetch()
        {
            return EF.DataPortal.Fetch<EF_DomValss>();
        }

		public static EF_DomValss Fetch(System.Linq.Expressions.Expression<Func<EF_DomVals, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_DomVals>(exp,values);
            return EF.DataPortal.Fetch<EF_DomValss>(lambda);
		}

		public static EF_DomValss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_DomValss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_DomValss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_DomVals, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_DomValss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_DomVals>(exp,values)});
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
