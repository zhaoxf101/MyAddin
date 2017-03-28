using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_FavoMenus))]
#if Dev
    [RunLocal]
#endif

	public class EF_FavoMenus:ReadOnlyBase<EF_FavoMenus>
    {
        #region Business Methods

		
        public string BName
        {
            get ;
            set ;
        }

		
        public int ObjectId
        {
            get ;
            set ;
        }

		
        public string UIType
        {
            get ;
            set ;
        }

		
        public int ParentId
        {
            get ;
            set ;
        }

		
        public int SortOrder
        {
            get ;
            set ;
        }

		
        public bool Folder
        {
            get ;
            set ;
        }

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string Flags
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_FavoMenus Create()
        {
            return EF.DataPortal.Create<EF_FavoMenus>();
        }

		public static EF_FavoMenus Fetch(System.Linq.Expressions.Expression<Func<EF_FavoMenus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_FavoMenus>(exp,values);
            return EF.DataPortal.Fetch<EF_FavoMenus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_FavoMenuss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_FavoMenuss:ReadOnlyListBase<EF_FavoMenuss,EF_FavoMenus>
    {
        #region Factory Methods

        public static EF_FavoMenuss Fetch()
        {
            return EF.DataPortal.Fetch<EF_FavoMenuss>();
        }

		public static EF_FavoMenuss Fetch(System.Linq.Expressions.Expression<Func<EF_FavoMenus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_FavoMenus>(exp,values);
            return EF.DataPortal.Fetch<EF_FavoMenuss>(lambda);
		}

		public static EF_FavoMenuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_FavoMenuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_FavoMenuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_FavoMenus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_FavoMenuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_FavoMenus>(exp,values)});
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
