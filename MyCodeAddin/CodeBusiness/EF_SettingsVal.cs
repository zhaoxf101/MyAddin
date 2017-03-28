using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SettingsVal))]
#if Dev
    [RunLocal]
#endif

	public class EF_SettingsVal:ReadOnlyBase<EF_SettingsVal>
    {
        #region Business Methods

		
        public string SetUnit
        {
            get ;
            set ;
        }

		
        public string ParaName
        {
            get ;
            set ;
        }

		
        public string ParaValue
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

		public static EF_SettingsVal Create()
        {
            return EF.DataPortal.Create<EF_SettingsVal>();
        }

		public static EF_SettingsVal Fetch(System.Linq.Expressions.Expression<Func<EF_SettingsVal, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SettingsVal>(exp,values);
            return EF.DataPortal.Fetch<EF_SettingsVal>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SettingsVals))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SettingsVals:ReadOnlyListBase<EF_SettingsVals,EF_SettingsVal>
    {
        #region Factory Methods

        public static EF_SettingsVals Fetch()
        {
            return EF.DataPortal.Fetch<EF_SettingsVals>();
        }

		public static EF_SettingsVals Fetch(System.Linq.Expressions.Expression<Func<EF_SettingsVal, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SettingsVal>(exp,values);
            return EF.DataPortal.Fetch<EF_SettingsVals>(lambda);
		}

		public static EF_SettingsVals Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SettingsVals>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SettingsVals Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SettingsVal, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SettingsVals>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SettingsVal>(exp,values)});
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
