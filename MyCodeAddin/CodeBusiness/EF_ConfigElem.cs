using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_ConfigElem))]
#if Dev
    [RunLocal]
#endif

	public class EF_ConfigElem:ReadOnlyBase<EF_ConfigElem>
    {
        #region Business Methods

		
        public string ConfigGroup
        {
            get ;
            set ;
        }

		
        public string ConfigName
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static EF_ConfigElem Create()
        {
            return EF.DataPortal.Create<EF_ConfigElem>();
        }

		public static EF_ConfigElem Fetch(System.Linq.Expressions.Expression<Func<EF_ConfigElem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_ConfigElem>(exp,values);
            return EF.DataPortal.Fetch<EF_ConfigElem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_ConfigElems))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_ConfigElems:ReadOnlyListBase<EF_ConfigElems,EF_ConfigElem>
    {
        #region Factory Methods

        public static EF_ConfigElems Fetch()
        {
            return EF.DataPortal.Fetch<EF_ConfigElems>();
        }

		public static EF_ConfigElems Fetch(System.Linq.Expressions.Expression<Func<EF_ConfigElem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_ConfigElem>(exp,values);
            return EF.DataPortal.Fetch<EF_ConfigElems>(lambda);
		}

		public static EF_ConfigElems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_ConfigElems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_ConfigElems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_ConfigElem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_ConfigElems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_ConfigElem>(exp,values)});
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
