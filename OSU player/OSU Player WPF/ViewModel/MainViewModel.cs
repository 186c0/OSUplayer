using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OSU_Player_WPF.Model;
using OSU_Player_WPF.Service;
using System.Collections.Generic;

namespace OSU_Player_WPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            //ֵ��ʼ��
            InitializeMainAppInfo();  //������Ϣ

        }

        LibService zLibService = new LibService();

        #region �Զ���������

        private MainAppInfo _MainAppInfos;
        /// <summary>
        /// ��������Ϣ
        /// </summary>
        public MainAppInfo MainAppInfos
        {
            get { return _MainAppInfos; }
            set
            {
                _MainAppInfos = value;
                this.RaisePropertyChanged("MainAppInfos");
            }
        }

        private List<BeatMapInfo> _BeatMapListing;
        /// <summary>
        /// BeatMap�б�
        /// </summary>
        public List<BeatMapInfo> BeatMapListing
        {
            get { return _BeatMapListing; }
            set
            {
                _BeatMapListing = value;
                this.RaisePropertyChanged("BeatMapListing");
            }
        }


        #endregion

        #region �¼�����

        private RelayCommand _ShowBeatMapWindow;
        /// <summary>
        /// ���洫�����������ť����ʵ����
        /// </summary>
        public RelayCommand ShowBeatMapWindow
        {
            get
            {
                return _ShowBeatMapWindow
                    ?? (_ShowBeatMapWindow = new RelayCommand(() =>
                                          {
                                              Ex_ShowBeatMapWindow();  //�������Ҫ��ʲô
                                          }));
            }
        }



        #endregion

        #region �����

        private void Ex_ShowBeatMapWindow()
        {
            throw new System.NotImplementedException();
        }

        private void GetBeatMapList()
        {
            //
        }

        #endregion

        #region ��ͨ�����߼�

        private void InitializeMainAppInfo()
        {
            this.MainAppInfos = zLibService.GetInitialize().InitializeMainAppinfo();  //��ʼ����������Ϣ
        }

        #endregion
    }
}