using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Settings))]
#if Dev
    [RunLocal]
#endif

	public class EF_Settings:ReadOnlyBase<EF_Settings>
    {
        #region Business Methods

		
        public string ParaName
        {
            get ;
            set ;
        }

		
        public string AGBlock
        {
            get ;
            set ;
        }

		
        public bool ClientX
        {
            get ;
            set ;
        }

		
        public string ParaType
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

		public static EF_Settings Create()
        {
            return EF.DataPortal.Create<EF_Settings>();
        }

		public static EF_Settings Fetch(System.Linq.Expressions.Expression<Func<EF_Settings, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Settings>(exp,values);
            return EF.DataPortal.Fetch<EF_Settings>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Settingss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Settingss:ReadOnlyListBase<EF_Settingss,EF_Settings>
    {
        #region Factory Methods

        public static EF_Settingss Fetch()
        {
            return EF.DataPortal.Fetch<EF_Settingss>();
        }

		public static EF_Settingss Fetch(System.Linq.Expressions.Expression<Func<EF_Settings, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Settings>(exp,values);
            return EF.DataPortal.Fetch<EF_Settingss>(lambda);
		}

		public static EF_Settingss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Settingss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Settingss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Settings, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Settingss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Settings>(exp,values)});
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
