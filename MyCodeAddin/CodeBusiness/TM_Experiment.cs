using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_Experiment))]
#if Dev
    [RunLocal]
#endif

	public class TM_Experiment:ReadOnlyBase<TM_Experiment>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExperCode
        {
            get ;
            set ;
        }

		
        public string ExperName
        {
            get ;
            set ;
        }

		
        public string ExperTypeCode
        {
            get ;
            set ;
        }

		
        public string ExperCateCode
        {
            get ;
            set ;
        }

		
        public decimal ExperHou
        {
            get ;
            set ;
        }

		
        public int EachGrpNum
        {
            get ;
            set ;
        }

		
        public string CourseCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
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

		public static TM_Experiment Create()
        {
            return EF.DataPortal.Create<TM_Experiment>();
        }

		public static TM_Experiment Fetch(System.Linq.Expressions.Expression<Func<TM_Experiment, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_Experiment>(exp,values);
            return EF.DataPortal.Fetch<TM_Experiment>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_Experiments))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_Experiments:ReadOnlyListBase<TM_Experiments,TM_Experiment>
    {
        #region Factory Methods

        public static TM_Experiments Fetch()
        {
            return EF.DataPortal.Fetch<TM_Experiments>();
        }

		public static TM_Experiments Fetch(System.Linq.Expressions.Expression<Func<TM_Experiment, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_Experiment>(exp,values);
            return EF.DataPortal.Fetch<TM_Experiments>(lambda);
		}

		public static TM_Experiments Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_Experiments>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_Experiments Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_Experiment, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_Experiments>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_Experiment>(exp,values)});
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
