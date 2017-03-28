using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AppModule))]
#if Dev
    [RunLocal]
#endif

	public class EF_AppModule:ReadOnlyBase<EF_AppModule>
    {
        #region Business Methods

		
        public string AppName
        {
            get ;
            set ;
        }

		
        public string UIType
        {
            get ;
            set ;
        }

		
        public string AGBlock
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PgmName
        {
            get ;
            set ;
        }

		
        public string CallParams
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static EF_AppModule Create()
        {
            return EF.DataPortal.Create<EF_AppModule>();
        }

		public static EF_AppModule Fetch(System.Linq.Expressions.Expression<Func<EF_AppModule, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AppModule>(exp,values);
            return EF.DataPortal.Fetch<EF_AppModule>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AppModules))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AppModules:ReadOnlyListBase<EF_AppModules,EF_AppModule>
    {
        #region Factory Methods

        public static EF_AppModules Fetch()
        {
            return EF.DataPortal.Fetch<EF_AppModules>();
        }

		public static EF_AppModules Fetch(System.Linq.Expressions.Expression<Func<EF_AppModule, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AppModule>(exp,values);
            return EF.DataPortal.Fetch<EF_AppModules>(lambda);
		}

		public static EF_AppModules Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AppModules>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AppModules Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AppModule, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AppModules>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AppModule>(exp,values)});
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
