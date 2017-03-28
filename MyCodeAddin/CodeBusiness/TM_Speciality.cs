using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_Speciality))]
#if Dev
    [RunLocal]
#endif

	public class TM_Speciality:ReadOnlyBase<TM_Speciality>
    {
        #region Business Methods

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public string SpecialityName
        {
            get ;
            set ;
        }

		
        public string SpecialityTypeCode
        {
            get ;
            set ;
        }

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
        public string PeriodLength
        {
            get ;
            set ;
        }

		
        public string FeeTypeCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TM_Speciality Create()
        {
            return EF.DataPortal.Create<TM_Speciality>();
        }

		public static TM_Speciality Fetch(System.Linq.Expressions.Expression<Func<TM_Speciality, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_Speciality>(exp,values);
            return EF.DataPortal.Fetch<TM_Speciality>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_Specialitys))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_Specialitys:ReadOnlyListBase<TM_Specialitys,TM_Speciality>
    {
        #region Factory Methods

        public static TM_Specialitys Fetch()
        {
            return EF.DataPortal.Fetch<TM_Specialitys>();
        }

		public static TM_Specialitys Fetch(System.Linq.Expressions.Expression<Func<TM_Speciality, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_Speciality>(exp,values);
            return EF.DataPortal.Fetch<TM_Specialitys>(lambda);
		}

		public static TM_Specialitys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_Specialitys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_Specialitys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_Speciality, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_Specialitys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_Speciality>(exp,values)});
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
