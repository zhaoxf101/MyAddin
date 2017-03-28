using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Config))]
#if Dev
    [RunLocal]
#endif

	public class FE_Config:ReadOnlyBase<FE_Config>
    {
        #region Business Methods

		
        public string ConfigGroupCode
        {
            get ;
            set ;
        }

		
        public string ConfigCode
        {
            get ;
            set ;
        }

		
        public string ConfigValue
        {
            get ;
            set ;
        }

		
        public string ConfigName
        {
            get ;
            set ;
        }

		
        public bool IsActive
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Config Create()
        {
            return EF.DataPortal.Create<FE_Config>();
        }

		public static FE_Config Fetch(System.Linq.Expressions.Expression<Func<FE_Config, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Config>(exp,values);
            return EF.DataPortal.Fetch<FE_Config>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Configs))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Configs:ReadOnlyListBase<FE_Configs,FE_Config>
    {
        #region Factory Methods

        public static FE_Configs Fetch()
        {
            return EF.DataPortal.Fetch<FE_Configs>();
        }

		public static FE_Configs Fetch(System.Linq.Expressions.Expression<Func<FE_Config, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Config>(exp,values);
            return EF.DataPortal.Fetch<FE_Configs>(lambda);
		}

		public static FE_Configs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Configs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Configs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Config, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Configs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Config>(exp,values)});
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
