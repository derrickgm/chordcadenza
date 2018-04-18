﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPlay.Forms.HowTo {
  public partial class frmHowToSyncAudioStream : Form {
    public frmHowToSyncAudioStream() {
      InitializeComponent();
    }

    private void cmdShowPlayMap_Click(object sender, EventArgs e) {
      P.frmSC.Activate();
    }

    private void cmdShowTrackMap_Click(object sender, EventArgs e) {
      P.frmSC.cmdMultiMap_Click(null, null);
    }

    //private void cmdLoadSong_Click(object sender, EventArgs e) {
    //  P.frmSC.LoadSongClick(Cfg.SamplesPathCHP_MID);
    //}

    private void cmdShowChordMap_Click(object sender, EventArgs e) {
      if (!P.F.MidiFileLoaded) {
        MessageBox.Show("MidiFile not loaded");
        return;
      }
      P.frmSC.cmdChordMap_Click(null, null);
    }

    private void cmdAutoSyncWindow_Click(object sender, EventArgs e) {
      Forms.HowTo.frmHowToAutoSyncWindow frm = new HowTo.frmHowToAutoSyncWindow();
      frm.Show();
    }

    private void frmHowToSyncAudioStream_Load(object sender, EventArgs e) {
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Forms.frmInitial.ApplyBoldAll(this);
    }
  }
}