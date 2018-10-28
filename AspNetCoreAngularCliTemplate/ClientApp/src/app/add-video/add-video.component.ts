import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
 
import { VideosService } from '../videos.service';
import { Video } from "../video";
 
@Component({
  selector: 'app-add-video',
  templateUrl: './add-video.component.html',
  styleUrls: ['./add-video.component.css']
})
export class AddVideoComponent {
  public genres: string[];
  public video: Video = {};
 
  constructor(
    private router: Router,
    private videosSvc: VideosService) {
    this.genres = [
      "",
      "Music",
      "Comedy",
      "Inspirational",
      "Tech",
      "News",
      "Sports"
    ];
  }
 
  addVideo() {
    this.videosSvc.addVideo(this.video)
      // The subscribe method here adds a listener to the asynchronous add
      // operation and the listener is called once the video is added.
      // Here, we are switching to the video list page after adding the video
      .subscribe(() => {
        this.router.navigateByUrl('/videolist');
      });
  }
}