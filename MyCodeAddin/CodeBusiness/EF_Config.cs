using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Config))]
#if Dev
    [RunLocal]
#endif

	public class EF_Config:ReadOnlyBase<EF_Config>
    {
        #region Business Methods

		
        public string GroupUnit
        {
            get ;
            set ;
        }

		
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

		
        public string ConfigValue
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

		public static EF_Config Create()
        {
            return EF.DataPortal.Create<EF_Config>();
        }

		public static EF_Config Fetch(System.Linq.Expressions.Expression<Func<EF_Config, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Config>(exp,values);
            return EF.DataPortal.Fetch<EF_Config>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Configs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Configs:ReadOnlyListBase<EF_Configs,EF_Config>
    {
        #region Factory Methods

        public static EF_Configs Fetch()
        {
            return EF.DataPortal.Fetch<EF_Configs>();
        }

		public static EF_Configs Fetch(System.Linq.Expressions.Expression<Func<EF_Config, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Config>(exp,values);
            return EF.DataPortal.Fetch<EF_Configs>(lambda);
		}

		public static EF_Configs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Configs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Configs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Config, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Configs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Config>(exp,values)});
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
